
export class paramsService{
    public static getParams(params?: Object){
         var paramsHttp = "";
        for(var fields in params){ 
          paramsHttp = paramsHttp + `${fields}=${params[fields]}&`  
        }
        return paramsHttp
    }
}