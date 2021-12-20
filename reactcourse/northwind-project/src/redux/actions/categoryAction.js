import * as actionTypes from "./actionTypes"

export function changeCategory(category){
    return {type:actionTypes.CHANGE_CATEGORY,payload:category}
}