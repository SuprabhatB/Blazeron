
const sizeSource = {
    CLIENT: 0,
    OFFSET: 1,
    SCROLL: 2,
}

window.BlazeronJSService = {
    logger: (l) => {
        console.log(l);
    },
    toggleSidebar: (sidebarRef, sidebarCollapseRef) => {
        if (sidebarCollapseRef) {
            sidebarCollapseRef.addEventListener('click', () => {
                if (sidebarRef) {
                    sidebarRef.classList.toggle("active");
                }
            });
        }
    },
    toggleSidebarMenu: (sidebarMenuRef) => {
        if (sidebarMenuRef) {
            const sibling = sidebarMenuRef.nextElementSibling;
            const sideMenuHeight = sidebarMenuRef.scrollHeight;

            if (sidebarMenuRef.classList.contains('collapsed')) {
                sidebarMenuRef.classList.remove('collapsed');
                sidebarMenuRef.setAttribute("aria-expanded", true);

                if (sibling) {
                    sibling.classList = '';
                    sibling.classList.add('collapsing');
                    sibling.style.height = `${sideMenuHeight}px`;

                    setTimeout(() => {
                        sibling.style.height = null;
                        sibling.classList.remove('collapsing');
                        sibling.classList.add('collapse', 'show');
                    }, sideMenuHeight);
                }
            }
            else {
                sidebarMenuRef.classList.add('collapsed');
                sidebarMenuRef.setAttribute("aria-expanded", false);

                if (sibling) {
                    sibling.classList = '';
                    sibling.classList.add('collapsing');

                    setTimeout(() => {
                        sibling.classList.remove('collapsing');
                        sibling.classList.add('collapse');
                    }, sideMenuHeight);
                }
            }
        }
    },
    setAutoHeight: () => {
        setFullHeight();
        window.addEventListener('resize', setFullHeight);
    },
    hashScroll: () => {
        const locationHash = location.hash;
        if (locationHash) {
            var elementTop = document.getElementById(locationHash.substring(1)).offsetTop;

            window.scrollTo({ top: elementTop, behavior: 'smooth' });
        }
    },
    addToBrowserHistory: (url, data, title) => {
        if (url) {
            history.pushState(data, title, url);
        }
    },
    setSectionSize: (elementReference, trimmedHeight) => {
        const windowSize = getWindowClientSize();

        if (!trimmedHeight) {
            trimmedHeight = 268;
        }

        const relativeHeight = windowSize.height - trimmedHeight;

        if (elementReference && elementReference instanceof HTMLElement) {

            const elementSize = getElementSize(elementReference, sizeSource.SCROLL);

            if (elementSize.height > relativeHeight) {
                elementReference.classList.add('scrollable');
            }

            elementReference.style.minHeight = `${relativeHeight}px`;
            elementReference.style.maxHeight = `${relativeHeight}px`;
        }

    }
}

const getWindowClientSize = (isUseWindowObjectOnly) => {
    if (isUseWindowObjectOnly) {
        return {
            height: (window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight),
            width: (window.innerWidth || document.documentElement.clientWidth || document.body.clientWidth)
        };
    }
    else {
        return {
            height: (screen.height || window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight),
            width: (screen.width || window.innerWidth || document.documentElement.clientWidth || document.body.clientWidth)
        };
    }
}

const getElementSize = (element, type) => {
    let height;
    let width;

    if (element) {
        if (type == sizeSource.OFFSET) {
            height = element.clientHeight;
            width = element.clientWidth;
        }
        else if (type == sizeSource.SCROLL) {
            height = element.offsetHeight;
            width = element.offsetWidth;
        }
        else {
            height = element.clientHeight;
            width = element.clientWidth;
        }
    }

    return {
        height: height,
        width: width
    };
}

const setFullHeight = () => {

    var windowHeight = getWindowClientSize().height;

    const elements = document.getElementsByClassName('js-fullheight');
    if (elements) {
        for (let ele of elements) {
            ele.style.height = `height: ${windowHeight}px`;
        }
    }
}
