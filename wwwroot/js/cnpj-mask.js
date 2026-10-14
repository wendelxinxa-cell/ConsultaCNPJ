window.cnpjMask = (function () {
    function maskValue(v) {
        v = v.replace(/\D/g, '').slice(0, 14);
        v = v.replace(/^(\d{2})(\d)/, '$1.$2');
        v = v.replace(/^(\d{2})\.(\d{3})(\d)/, '$1.$2.$3');
        v = v.replace(/^(\d{2})\.(\d{3})\.(\d{3})(\d)/, '$1.$2.$3/$4');
        v = v.replace(/^(\d{2})\.(\d{3})\.(\d{3})\/(\d{4})(\d)/, '$1.$2.$3/$4-$5');
        return v;
    }

    function apply(el) {
        if (!el) return;
        el.addEventListener('input', function (e) {
            var start = el.selectionStart;
            var old = el.value;
            var newValue = maskValue(old);
            el.value = newValue;
            // try keep caret at end for simplicity
            if (start) el.setSelectionRange(el.value.length, el.value.length);
        });
        // initial format
        el.value = maskValue(el.value || '');
    }

    function applyById(id) {
        var el = document.getElementById(id);
        apply(el);
    }

    return {
        apply: apply,
        applyById: applyById
    };
})();
