var connection = new signalR.HubConnectionBuilder()
    //.configureLogging(signalR.LogLevel.Information)
    .withAutomaticReconnect()
    .withUrl("/hubs/question", signalR.HttpTransportType.WebSockets).build();

// Handle QuestionClosed event
connection.on("QuestionClosed", function (questionId) {
        $('.btn[data-bs-target="#answerModal"]').hide();
        $('.btn[data-bs-target="#reportModal-Question"]').hide();
        // Update the question status badge
        $('.badge.bg-success').removeClass('bg-success').addClass('bg-danger').text('Closed');
  
});

connection.on("ContentRemoved", function (itemId, itemType) {
    if (itemType === "Question" && itemId === window.currentQuestionId) {
        $('.question-card-header').remove();
        $('.question-card-footer').remove();
        $('.question-card-body').html('<div class="alert alert-danger d-flex justify-content-center align-items-center" role="alert">' +
            '<i class="bi bi-exclamation-triangle-fill me-2"></i>' +
            '<div class="d-flex justify-content-center align-items-center">' +
            'This item has been removed due to inappropriate content.' +
            '</div></div>');
    } else if (itemType === "Response" || itemType === "ResponseComment") {
        $('[data-response-id="' + itemId + '"]').closest('.card').html('<div class="alert alert-danger d-flex justify-content-center align-items-center" role="alert">' +
            '<i class="bi bi-exclamation-triangle-fill me-2"></i>' +
            '<div class="d-flex justify-content-center align-items-center">' +
            'This item has been removed due to inappropriate content.' +
            '</div></div>');
    }
});

// Handle ResponseAdded event
connection.on("ResponseAdded", function (response) {
    if (response.questionId == window.currentQuestionId) {
    
        var responseHtml = `
            <div class="col-md-12 m-2">
                <div class="card mt-3 rounded" style="background-color: #fff !important;" data-response-id="${response.id}">
                    <div class="card-body d-flex flex-row p-2">
                        <div class="d-flex flex-column justify-content-start align-items-center" style="width:10%;">
                            <img src="https://via.placeholder.com/64" class="rounded-circle mb-1" alt="User Image">
                            <div class="d-flex flex-column justify-content-center align-items-center">
                                <i class="bi bi-caret-up-fill h2"></i>
                                <p class="h4 m-0 vote-count" data-response-id="${response.id}">0</p>
                                <i class="bi bi-caret-down-fill h2"></i>
                            </div>
                        </div>
                        <div class="question-content ms-2" style="width:90%;">
                            <div class="d-flex flex-row justify-content-end align-items-center">
                                <i class="bi bi-hand-thumbs-up m-2 h3 vote-btn" data-response-id="${response.id}" data-vote-type="upvote"></i>
                                <i class="bi bi-hand-thumbs-up-fill m-2 h3 voted-btn" data-response-id="${response.id}" data-vote-type="upvote" style="display:none;"></i>
                                <i class="bi bi-hand-thumbs-down m-2 h3 vote-btn" data-response-id="${response.id}" data-vote-type="downvote"></i>
                                <i class="bi bi-hand-thumbs-down-fill m-2 h3 voted-btn" data-response-id="${response.id}" data-vote-type="downvote" style="display:none;"></i>
                            </div>
                            <p class="h4">${response.body}</p>
                            <div class="editor question-editor w-100">
                                ${response.codeSnippet}
                            </div>
                            <div>
                                ${response.codeSmellList.map(cs => `<span class="badge bg-primary h1"> ${cs.name} </span>`).join('')}
                            </div>
                            <div>
                                ${response.refactoringTechniques.map(rt => `<span class="badge bg-secondary h1"> ${rt.name} </span>`).join('')}
                            </div>
                        </div>
                    </div>
                    <div class="card-footer question-card-footer action-buttons d-flex flex-column mt-2" style="border:none; background:#fff !important;">
                        <div class="d-flex flex-row justify-content-between">
                            <div>
                                <button class="btn light-btn comment-btn" type="button" data-bs-toggle="collapse" data-bs-target="#collapseExample-${response.id}" aria-expanded="false" aria-controls="collapseExample-${response.id}">View comments</button>
                                <button class="btn light-btn" data-bs-toggle="modal" data-bs-target="#commentModal-${response.id}">Add a comment</button>
                            </div>
                            <p class="text-center"> Answered by ${response.userName} </p>
                            <button class="btn btn-danger ml-2" data-bs-toggle="modal" data-bs-target="#reportModal-${response.id}"><i class="bi bi-flag"></i></button>
                        </div>
                    </div>
                    <div class="collapse" id="collapseExample-${response.id}">
                    </div>
                </div>
            </div>
        `;
        $('.response-row').append(responseHtml);

        // Update the answer count
        var answerCountElement = $('#answer-count');
        var currentCount = parseInt(answerCountElement.attr('data-count'));
        currentCount += 1;
        answerCountElement.attr('data-count', currentCount);
        answerCountElement.text(`${currentCount} ${currentCount > 1 ? "Answers" : "Answer"}`);

    }
});

// Handle VoteUpdated event
connection.on("VoteUpdated", function (responseId, totalVotes) {
    $('.vote-count[data-response-id="' + responseId + '"]').text(totalVotes);
});


// Add the CommentAdded event handler
connection.on("CommentAdded", function (comment) {
    if (comment.questionId == window.currentQuestionId) {
        var commentHtml = `
            <div class="card card-body">
                ${comment.body}
                <small class="text-muted">${comment.userName} replied ${new Date(comment.commentDate).toLocaleString()}</small>
            </div>
        `;

        // Append the new comment HTML to the appropriate response
        $('#collapseExample-' + comment.responseId).append(commentHtml);
    }
});


// Start connection
function fulfilled() {
    // Do something on start
    console.log("Connection to Question Hub Successful");
}

function rejected(error) {
    console.error("Connection to Question Hub Failed: ", error);
}


connection.start().then(fulfilled).catch(rejected); // Using .catch for error handling
