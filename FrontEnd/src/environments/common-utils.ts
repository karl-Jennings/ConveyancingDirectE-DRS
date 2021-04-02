import { Injectable } from "@angular/core";
import { MatDialog, MatDialogRef } from "@angular/material/dialog";
import { ProgressComponent } from "src/app/angular-dialogs/progress/progress.component";

@Injectable()
export class CommonUtils {

    static formatDate(date: string | number | Date) {
        const d = new Date(date);
        let month = '' + (d.getMonth() + 1);
        let day = '' + d.getDate();
        const year = d.getFullYear();
        if (month.length < 2) month = '0' + month;
        if (day.length < 2) day = '0' + day;
        return [day, month, year].join('-');
    }

    static getBase64(file: Blob) {
        var fileStr;
        let reader = new FileReader();
        reader.readAsDataURL(file);
        reader.onload = function () {
            //me.modelvalue = reader.result;
            fileStr = reader.result;
        };
        reader.onerror = function (error) {
            console.log('Error: ', error);
        };
        return fileStr;
    }

    static showProgress(dialog: MatDialog): MatDialogRef<ProgressComponent, any> {
        return dialog.open(ProgressComponent, {
            data: {},
        });
    }
}