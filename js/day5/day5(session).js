
        let input = document.getElementById("Input");

        function saveText() {
            sessionStorage.setItem("saved", input.value);
        }

        function deleteText() {
            input.value = "";
            sessionStorage.removeItem("saved");
        }

        input.value = sessionStorage.getItem("saved") || "";

