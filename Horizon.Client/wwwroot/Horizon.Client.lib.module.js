function debounce(func, wait) {
    let timeout;
    return function(...args) {
        clearTimeout(timeout);
        timeout = setTimeout(() => func.apply(this, args), wait);
    };
}

const initialize = debounce(() => {
    initFlowbite();
}, 100);

const observer = new MutationObserver((mutationsList, observer) => {
    for (let mutation of mutationsList) {
        if (mutation.type === 'childList') {
            initialize();
        }
    }
});

observer.observe(document.body, { childList: true, subtree: true });
