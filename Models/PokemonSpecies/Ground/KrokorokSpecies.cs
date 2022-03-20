using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Krokorok Species to store common natural stats of all Krokoroks
	#region KrokorokSpecies
	public class KrokorokSpecies : PokemonSpecies
	{
#nullable enable
		private static KrokorokSpecies? _instance = null;
#nullable restore
        public static KrokorokSpecies Instance => _instance ?? (_instance = new KrokorokSpecies());

		#region KrokorokSpecies Constructor
		public KrokorokSpecies() : base(
			552,
			"Krokorok",
			Ground.Instance, Dark.Instance,
			1.0,
			33.4,
			new PokemonStats(
				60, // HPs
				82, 45, // Attack & Defense
				45, 45, // Spacial Attack & Defense
				74 // Speed
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
				"Cut",
				"Sand-Attack",
				"Thrash",
				"Leer",
				"Bite",
				"Roar",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Rage",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Payback",
				"Assurance",
				"Embargo",
				"Fling",
				"Dark-Pulse",
				"Aqua-Tail",
				"Earth-Power",
				"Shadow-Claw",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Snarl",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}