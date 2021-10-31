namespace Ep022_Interfaces
{
    // interface → for Name convention for best practices type "I" before the name of the interface ex: ILoader
    interface ILoader
    {
        // this two method must be implemented in the dervied class

        void Load(); 

        void Unload();
        
    }
}
