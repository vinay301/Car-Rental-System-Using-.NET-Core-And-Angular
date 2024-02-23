export interface CarRentalAgreement {
    id: number;
    customerName: string;
    startDate: Date;
    endDate: Date;
    carId: number;
    rentalPrice: number;
    carName : string;
    isRented : boolean;
  }