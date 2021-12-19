import { combineReducers } from "redux";
import counterReducer from "./counterReducer";

const reducers = combineReducers({
    counterReducer
    //counterReducer:counterReducer
    //Aynı isimde değişken oluşuturup ona atıyor değeri.
})

export default reducers;