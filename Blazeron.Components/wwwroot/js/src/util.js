// adds a classname to the specified element
export function addClass(element, classname) {
    if (element && classname) {
        element.classList.add(classname);
    }
}

// removes a classname from the specified element
export function removeClass(element, classname) {
    if (element && classname) {
        if (element.classList.contains(classname)) {
            element.classList.remove(classname);
        }
    }
}

// toggles a classname on the given element id
export function toggleClass(element, classname) {
    if (element && classname) {
        if (element.classList.contains(classname)) {
            element.classList.remove(classname);
        } else {
            element.classList.add(classname);
        }
    }
}

// sets the input focuses to the given element
export function focus(element, elementId, scrollToElement) {
    element = getRequiredElement(element, elementId);

    if (element) {
        element.focus({
            preventScroll: !scrollToElement
        });
    }
}

// selects the given element
export function select(element, elementId, focus) {
    if (focus) {
        focus(element, elementId, true);
    }

    element = getRequiredElement(element, elementId);

    if (element) {
        element.select();
    }
}

// scrolls to the anchor link 
export function scrollAnchorIntoView(elementId) {
    const element = document.getElementById(elementId);

    if (element) {
        element.scrollIntoView();
        window.location.hash = elementId;
    }
}

// scrolls to the element
export function scrollElementIntoView(elementId, smooth) {
    const element = document.getElementById(elementId);

    if (element) {
        let top;
        if (element.offsetTop < element.parentElement.scrollTop || element.clientHeight > element.parentElement.clientHeight) {
            top = element.offsetTop;
        }
        else if (element.offsetTop + element.offsetHeight > element.parentElement.scrollTop + element.parentElement.clientHeight) {
            top = element.offsetTop + element.offsetHeight - element.parentElement.clientHeight;
        }

        var behavior = smooth ? "smooth" : "instant";

        element.parentElement.scrollTo({ top: top, behavior: behavior });
    }
}

export function getRequiredElement(element, elementId) {
    if (element)
        return element;

    return document.getElementById(elementId);
}


export function getUserAgent() {
    return navigator.userAgent;
}

export function copyToClipboard(element, elementId) {
    element = getRequiredElement(element, elementId);

    if (!element)
        return;

    if (navigator.clipboard) {
        navigator.clipboard.writeText(element.innerText);
    }
}