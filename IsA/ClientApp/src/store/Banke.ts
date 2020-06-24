import { Action, Reducer } from 'redux';
import { AppThunkAction } from '.';

// -----------------
// STATE - This defines the type of data maintained in the Redux store.

export interface BankeState {
    isLoading: boolean;
    startDateIndex?: number;
    banke: Banka[];
}

export interface Banka {
    id: number;
    naziv: string;
    mesto: string;
    adresa: string;
}

// -----------------
// ACTIONS - These are serializable (hence replayable) descriptions of state transitions.
// They do not themselves have any side-effects; they just describe something that is going to happen.

interface RequestBankeAction {
    type: 'REQUEST_BANKE';
    startDateIndex: number;
}

interface ReceiveBankeAction {
    type: 'RECEIVE_BANKE';
    startDateIndex: number;
    banke: Banka[];
}

// Declare a 'discriminated union' type. This guarantees that all references to 'type' properties contain one of the
// declared type strings (and not any other arbitrary string).
type KnownAction = RequestBankeAction | ReceiveBankeAction;

// ----------------
// ACTION CREATORS - These are functions exposed to UI components that will trigger a state transition.
// They don't directly mutate state, but they can have external side-effects (such as loading data).

export const actionCreators = {
    requestBanke: (startDateIndex: number): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        const appState = getState();
        if (appState && appState.banke && startDateIndex !== appState.banke.startDateIndex) {
            fetch(`banka`)
                .then(response => response.json() as Promise<Banka[]>)
                .then(data => {
                    dispatch({ type: 'RECEIVE_BANKE', startDateIndex: startDateIndex, banke: data });
                });

            dispatch({ type: 'REQUEST_BANKE', startDateIndex: startDateIndex });
        }
    }
};

// ----------------
// REDUCER - For a given state and action, returns the new state. To support time travel, this must not mutate the old state.

const unloadedState: BankeState = { banke: [], isLoading: false };

export const reducer: Reducer<BankeState> = (state: BankeState | undefined, incomingAction: Action): BankeState => {
    if (state === undefined) {
        return unloadedState;
    }

    const action = incomingAction as KnownAction;
    switch (action.type) {
        case 'REQUEST_BANKE':
            return {
                startDateIndex: action.startDateIndex,
                banke: state.banke,
                isLoading: true
            };
        case 'RECEIVE_BANKE':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.startDateIndex === state.startDateIndex) {
                return {
                    startDateIndex: action.startDateIndex,
                    banke: action.banke,
                    isLoading: false
                };
            }
            break;
    }

    return state;
};
