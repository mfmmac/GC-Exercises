const calculatorGrid = document.querySelector('.calc_grid')
const calculatorDisplay = document.querySelector('.calc_display')
const calculatorButtons = calculatorGrid.querySelector('.calc_buttons')
let firstValue = calculatorGrid.dataset.firstValue
let secondValue = calculatorGrid.dataset.secondValue

calculatorButtons.addEventListener('click', event=>{
    if(event.target.matches('button')){
        const button = event.target
        const buttonContent = button.textContent
        const action = button.dataset.action
        determineAction(action, buttonContent)
    }
});

function determineAction(action, buttonContent){
    if(!action){
        console.log("Number pressed")
        calculatorDisplay.textContent = buttonContent
        secondValue = buttonContent
    } else{
       if(action === 'add' || action ==='subtract' || action === 'multiply' || action === 'divide'){
            firstValue = calcDisplay.textContent
            operator = action
       }
       if(action === 'equals'){
            calculatorDisplay.textContent = compute(parseFloat(firstValue), parseFloat(secondValue), operator)
       }
    }
}

function compute(firstValue, secondValue, operator){
    let result = 0;
    switch(operator){
        case 'add' :
            result = parseFloat(firstValue + secondValue)
            break;
        case 'subtract' :
            result = parseFloat(firstValue - secondValue)
            break;
        case 'divide' :
            result = parseFloat(firstValue / secondValue)
            break;
        case 'multiply' :
            result = parseFloat(firstValue * secondValue)
            break;
    }
    return result;
}