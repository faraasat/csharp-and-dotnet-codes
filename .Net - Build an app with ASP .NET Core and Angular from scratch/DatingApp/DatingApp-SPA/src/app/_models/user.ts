import { Photo } from './photo';

export interface User {
    id: number;
    username: string;
    knownAs: string;
    age: number;
    gender: string;
    created: Date;
    lastActive: Date;
    photoUrl: string;
    city: string;
    country: string;
    // optional properties come after the normal properties
    interests?: string;
    introduction?: string;
    lookingFor?: string;
    photos?: Photo[];
}
