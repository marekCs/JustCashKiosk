# Just Cash Kiosk - Project Overview
1. Views:

The user interface of the application should consist of the following Views:

    ShellView: This is the main window that shows up when the application is launched. It is essentially the primary window provided by the Caliburn.Micro package.
    PinEnterView: This view is displayed after the card has been inserted. It manages the input of the PIN.
    AmountSelectionView: This view appears after the PIN has been entered. It allows the user to select the amount they want to purchase in Bitcoin.
    ConfirmationView: This view is displayed after the amount has been selected. It manages the transaction confirmation.
    ReceiptView: This view appears after a successful transaction. It displays the successful purchase and notifies about the issuance of the receipt.

2. ViewModels:

For each of the above Views, there is a corresponding ViewModel:

    PinEnterViewModel
    AmountSelectionViewModel
    ConfirmationViewModel
    ReceiptViewModel

These ViewModels contain all the necessary logic for interacting with each View.
3. Services:

Several services will be needed to interact with external systems:

    CardReaderService: Communicates with the card reader.
    PinPadService: Communicates with the PIN input field.
    BitcoinPurchaseService: Communicates with the service for purchasing Bitcoin.
    ReceiptPrinterService: Communicates with the receipt printer.

These services will be injected into the ViewModels using AutoFac for dependency management.
4. Display Button Structure:

The first row has an "About us" button on the left and a "Cash Withdrawal" button on the right.

The second row includes a "Quick Loan" button on the right.

The third row has a "Why Bitcoin" button on the left, a "My Bitcoin History" button in the middle, and a "Buy Bitcoin" button on the right.

The fourth row features a "Bitcoin price chart" button on the left.

Each of these buttons is associated with a respective command in the ViewModel to perform certain actions when clicked. The application uses Material Design icons to enhance the user interface and provide a modern and clean look.
