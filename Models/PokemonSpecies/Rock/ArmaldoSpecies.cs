using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Armaldo Species to store common natural stats of all Armaldos
	#region ArmaldoSpecies
	public class ArmaldoSpecies : PokemonSpecies
	{
#nullable enable
		private static ArmaldoSpecies? _instance = null;
#nullable restore
        public static ArmaldoSpecies Instance => _instance ?? (_instance = new ArmaldoSpecies());

		#region ArmaldoSpecies Constructor
		public ArmaldoSpecies() : base(
			348,
			"Armaldo",
			Rock.Instance, Bug.Instance,
			1.5,
			68.2,
			new PokemonStats(
				75, // HPs
				125, 100, // Attack & Defense
				70, 80, // Spacial Attack & Defense
				45 // Speed
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
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Water-Gun",
				"Hyper-Beam",
				"Low-Kick",
				"Seismic-Toss",
				"Strength",
				"String-Shot",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Mud-Sport",
				"Crush-Claw",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Rock-Polish",
				"Aqua-Tail",
				"X-Scissor",
				"Earth-Power",
				"Giga-Impact",
				"Flash-Cannon",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Struggle-Bug",
				"Bulldoze",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}