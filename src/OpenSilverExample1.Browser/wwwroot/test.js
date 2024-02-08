function getJavaScriptObject() {
    function resolveAfter2Seconds() {
        return new Promise((resolve) => {
            setTimeout(() => {
                resolve('resolved');
            }, 2000);
        });
    };

    return {
        sendMessage: async function (str) {
            console.log('waiting...');
            const result = await resolveAfter2Seconds();
            return `Received: ${str}`;
        },
    };
}