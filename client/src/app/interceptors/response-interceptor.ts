import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent, HttpResponse } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

export class ResponseInterceptor implements HttpInterceptor{

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {

        return next.handle(request).pipe(
            map((event: HttpResponse<any>) => {
                if(!event || !event['body']) return event;

                var response = event['body'];
                if(response.status = '200') event = event.clone({body: response.body});
                else alert(response.message);
                return event;
            })
        );
    }
}