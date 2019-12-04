export interface Recipient{
        id: string;
        name:string;
        city:string;
        street:string;
        number:string;
}

export interface RecipientList {
  items: Recipient[];
  totalItems: number;
}
