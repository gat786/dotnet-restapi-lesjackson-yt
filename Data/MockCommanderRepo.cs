using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
                new Command{
                    id=0,
                    HowTo="Boil an Egg",
                    Line="Boil Water",
                    Platform="Kettle and Pan"
                },
                new Command{
                    id=1,
                    HowTo="Cut Bread",
                    Line="Get a knife",
                    Platform="knife & chopping board"
                },
                new Command{
                    id=2,
                    HowTo="Make a cup of tea",
                    Line="Place teabag in cup",
                    Platform="Kettle & Cup"
                }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{
                id=0,
                HowTo="Boil an Egg",
                Line="Boil Water",
                Platform="Kettle and Pan"
            };
        }
    }
}