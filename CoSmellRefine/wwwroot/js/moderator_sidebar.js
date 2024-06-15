﻿(function () {
    const sidebar = document.querySelector(".sidebar");
    const menu = document.querySelector("#menu");

    const main = document.querySelector(".user-main");

    const menu_container = document.querySelector(".menu-container");
    const logout_container = document.querySelector(".logout-container");

    const icon_logout = document.querySelector(".icon-logout");


    const dashboard = document.querySelector("#dashboard");
    const discussion = document.querySelector("#discussion");
    const issue = document.querySelector("#issue");


    let previousToggled = null;
    let currentToggled = null;


    dashboard.addEventListener("click", (e) => {
        toggleMenu(dashboard);
    });

    discussion.addEventListener("click", (e) => {
        toggleMenu(dicussion);
    });

    issue.addEventListener("click", (e) => {
        toggleMenu(issue);
    });




    const toggleMenu = (button) => {
        if (previousToggled && button !== menu) {
            untoggleMenu(previousToggled);
        }

        button.classList.add("toggled");
        button.style.backgroundColor = "#FCFCAE";

        if (button !== menu) {
            previousToggled = button;
        }
    };

    const untoggleMenu = (button) => {
        button.classList.remove("toggled");
        button.style.backgroundColor = "#1FFFE86";
    };

    menu.addEventListener("click", (e) => {
        console.log("helo");
        sidebar.classList.contains("active") ? closeMenu() : openMenu();
    });

    const openMenu = () => {
        sidebar.classList.add("active");
        sidebar.style.width = "250px";

        toggleMenu(menu);

        let menu_logo = document.createElement("img");
        menu_logo.id = "menu-logo";
        menu_logo.src = "../images/logo.svg";
        menu_logo.style.width = "40px";
        menu_container.style.paddingLeft = "15px";
        menu_container.insertBefore(menu_logo, menu_container.childNodes[0]);


        let p_dash = document.createElement("p");
        p_dash.id = "p-dashboard";
        p_dash.innerHTML = "Dashboard";
        dashboard.style.width = "220px";
        dashboard.style.justifyContent = "left";
        dashboard.appendChild(p_dash);

        let p_discussion = document.createElement("p");
        p_discussion.id = "p-discussion";
        p_discussion.innerHTML = "Discussion";
        discussion.style.width = "220px";
        discussion.style.justifyContent = "left";
        discussion.appendChild(p_discussion);

        let p_issue = document.createElement("p");
        p_issue.id = "p-issue";
        p_issue.innerHTML = "Reported Issue";
        issue.style.width = "220px";
        issue.style.justifyContent = "left";
        issue.appendChild(p_issue);



        icon_logout.style.width = "25%";

        let user_container = document.createElement("div");
        user_container.id = "user-container";

        let user_name = document.createElement("p");
        user_name.id = "user-name";
        user_name.innerHTML = "Shriraam Nagarajan";

        let user_role = document.createElement("p");
        user_role.id = "user-role";
        user_role.innerHTML = "Admin";

        user_container.appendChild(user_name);
        user_container.appendChild(user_role);

        logout_container.insertBefore(user_container, logout_container.childNodes[0]);


        logout_container.style.paddingLeft = "15px";

        main.style.width = "calc(100% - 250px)";
    };

    const closeMenu = () => {
        menu_container.removeChild(document.getElementById("menu-logo"));
        menu_container.style.paddingLeft = "0px";

        untoggleMenu(menu);

        dashboard.removeChild(document.getElementById("p-dashboard"));
        dashboard.style.width = "50px";
        dashboard.style.justifyContent = "center";

        discussion.removeChild(document.getElementById("p-discussion"));
        discussion.style.width = "50px";
        discussion.style.justifyContent = "center";

        issue.removeChild(document.getElementById("p-issue"));
        issue.style.width = "50px";
        issue.style.justifyContent = "center";

        logout_container.removeChild(document.getElementById("user-container"));
        logout_container.style.paddingLeft = "0px";

        icon_logout.style.width = "100%";

        sidebar.classList.remove("active");
        sidebar.style.width = "78px";

        main.style.width = "calc(100% - 78px)";
    };


})();

