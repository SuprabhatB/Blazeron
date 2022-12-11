
class AlertService {
    close(elementId, effectType, effectDuration, callbackReference, callbackMethod) {
        if (elementId) {
            elementId.classList.add('animation', effectType);

            if (parseInt(effectDuration) == 0) {
                effectDuration = 500;
            }

            setTimeout(() => {
                elementId.classList.remove('animation', effectType);

                if (callbackReference) {
                    callbackReference.invokeMethodAsync(callbackMethod);
                }
            }, effectDuration);
        }
    }
}

window.alertService = new AlertService();