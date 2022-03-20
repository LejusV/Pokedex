using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Diglett Species to store common natural stats of all Digletts
	#region DiglettSpecies
	public class DiglettSpecies : PokemonSpecies
	{
#nullable enable
		private static DiglettSpecies? _instance = null;
#nullable restore
        public static DiglettSpecies Instance => _instance ?? (_instance = new DiglettSpecies());

		#region DiglettSpecies Constructor
		public DiglettSpecies() : base(
			50,
			"Diglett",
			Ground.Instance,
			0.2,
			0.8,
			new PokemonStats(
				10, // HPs
				55, 25, // Attack & Defense
				35, 45, // Spacial Attack & Defense
				95 // Speed
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
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Bide",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Pursuit",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Beat-Up",
				"Uproar",
				"Memento",
				"Facade",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Aerial-Ace",
				"Natural-Gift",
				"Sucker-Punch",
				"Earth-Power",
				"Shadow-Claw",
				"Mud-Bomb",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Final-Gambit",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}