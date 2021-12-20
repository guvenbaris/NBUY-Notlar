import rootReducer from "./index";
import {createStore} from "redux";

export default function configureStore(){
    return createStore(rootReducer)
}