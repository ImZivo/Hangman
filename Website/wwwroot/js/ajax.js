"use strict";

// on form element, provide the following data
// class: ajax-form

$(document).ready(function () {
    $("input.ajax-form-submit").click(function () {
        var form = $(this).closest("form");
        form.submit();
    });

    $("form.ajax-form").on("submit", function (event) {
        event.preventDefault();

        var method = $(this).attr("method");
        var url = $(this).attr("action");
        var inputs = $(this).find("input, select, textarea")
            .map(function () {
                var name = $(this).attr("name");

                if ($(this).attr("type") === "checkbox") {
                    return { name: name, value: $(this).is(":checked") };
                } else {
                    return { name: name, value: $(this).val() };
                }
            });
        var data = {};
        for (var i = 0; i < inputs.length; i++) {
            var input = inputs[i];
            data[input.name] = input.value;
        }
        const successDelayAttr = $(this).attr("data-successDelay");
        const successDelay = (successDelayAttr === undefined || successDelayAttr === 'true');
        const postSuccessAction = $(this).attr("data-ajaxSuccess");
        const postErrorAction = $(this).attr("data-ajaxError");

        disableAll();

        $.ajax({
            url: url,
            method: method,
            data: data,
            dataType: "json",
            async: true,
            cache: false,
            success: function (response) {
                enableAll();
                if (response.success) {
                    if (successDelay === undefined || successDelay === true) {
                        setSuccessMessage(response.text);
                    } else {
                        showSuccess(response.text);
                    }
                    eval(postSuccessAction);
                } else {
                    showError(response.text);
                    eval(postErrorAction);
                }
            }
        });
    });

    function disableAll() {
        $("input:not(.readonly):not(.disabled), select:not(.readonly):not(.disabled), textarea:not(.readonly):not(.disabled)").attr("readonly", "readonly");
        $("input:not(.readonly):not(.disabled), button:not(.readonly):not(.disabled), textarea:not(.readonly):not(.disabled)").attr("disabled", "disabled");
    }

    function enableAll() {
        $("input:not(.readonly):not(.disabled), select:not(.readonly):not(.disabled), textarea:not(.readonly):not(.disabled)").removeAttr("readonly");
        $("input:not(.readonly):not(.disabled), button:not(.readonly):not(.disabled), textarea:not(.readonly):not(.disabled)").removeAttr("disabled");
    }
});