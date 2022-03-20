using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Riolu Species to store common natural stats of all Riolus
	#region RioluSpecies
	public class RioluSpecies : PokemonSpecies
	{
#nullable enable
		private static RioluSpecies? _instance = null;
#nullable restore
        public static RioluSpecies Instance => _instance ?? (_instance = new RioluSpecies());

		#region RioluSpecies Constructor
		public RioluSpecies() : base(
			447,
			"Riolu",
			Fighting.Instance,
			0.7,
			20.2,
			new PokemonStats(
				40, // HPs
				70, 40, // Attack & Defense
				35, 40, // Spacial Attack & Defense
				60 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Headbutt",
				"Bite",
				"Roar",
				"Low-Kick",
				"Counter",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Screech",
				"Double-Team",
				"Swift",
				"High-Jump-Kick",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Mind-Reader",
				"Snore",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Follow-Me",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Secret-Power",
				"Blaze-Kick",
				"Meteor-Mash",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Iron-Defense",
				"Bulk-Up",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Fling",
				"Copycat",
				"Magnet-Rise",
				"Force-Palm",
				"Poison-Jab",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Nasty-Plot",
				"Bullet-Punch",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Captivate",
				"Low-Sweep",
				"Round",
				"Circle-Throw",
				"Retaliate",
				"Final-Gambit",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}