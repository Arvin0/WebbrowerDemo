function showDataFromForm(userName) {
            document.getElementById("userData").innerText = userName;
            return "success";
        };

        function doAdd(a, b) {
            return a + b;
        };

        function transferDataToForm() {
            return document.getElementById("dataTransferedToForm").innerText;
        }