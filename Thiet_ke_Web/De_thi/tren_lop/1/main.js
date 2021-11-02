const inputValue = document.getElementById('input')
const outputValue = document.getElementById('output')
const submitData = document.getElementById('submit')

submitData.onclick = function() {
    var n = inputValue.value
    var sum = 0
    for(var i = 0; i <= n; i++) {
        if(Math.sqrt(i) % 1 == 0) {
            sum += i;
        }
    }
    return outputValue.value = sum
}