import { Injectable } from '@angular/core';
import * as signalR from "@aspnet/signalr";
import { GPSModel } from '../_interfaces/GPSModel.model';

@Injectable({
  providedIn: 'root'
})
export class SignalRService {
  public data: GPSModel[];
  public bradcastedData: GPSModel[];

private hubConnection: signalR.HubConnection

  public startConnection = () => {
    this.hubConnection = new signalR.HubConnectionBuilder()
                            .withUrl('https://localhost:5005/bus')
                            .build();

    this.hubConnection
      .start()
      .then(() => console.log('Connection started'))
      .catch(err => console.log('Error while starting connection: ' + err))
  }

  public addGPSDataListener = () => {
    this.hubConnection.on('transfergpsdata', (data) => {
      this.data = data;
      console.log(data);
    });
  }

  public broadcastGPSData = () => {
    this.hubConnection.invoke('broadcastgpsdata', this.data)
    .catch(err => console.error(err));
  }

  public addBroadcastGPSDataListener = () => {
    this.hubConnection.on('broadcastgpsdata', (data) => {
      this.bradcastedData = data;
    })
  }
}
