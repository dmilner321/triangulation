import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';


@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {

    public triangle: any; 
    public http: Http;
    public triangleresult: string;


    gotTriangle = false;
    
    constructor(http: Http) {
        this.http = http;
    }

    getTriangle(gridLocation: string) {
        //TODO:  extract to provider
        this.http.get('api/Triangulation/GetTriangle?gridlocation='+gridLocation).subscribe(result => {
            this.triangle = result.json() as Triangle;
            this.triangleresult = JSON.stringify(this.triangle);
            console.log(this.triangleresult);
        }, error => console.error(error))
    }
}

interface Triangle {
    gridLocation: string;
    v1x: number;
    v1y: number;
    v2x: number;
    v2y: number;
    v3x: number;
    v3y: number;
    orientation: string;
}
