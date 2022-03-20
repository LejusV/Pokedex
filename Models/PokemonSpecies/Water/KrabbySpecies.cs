using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Krabby Species to store common natural stats of all Krabbys
	#region KrabbySpecies
	public class KrabbySpecies : PokemonSpecies
	{
#nullable enable
		private static KrabbySpecies? _instance = null;
#nullable restore
        public static KrabbySpecies Instance => _instance ?? (_instance = new KrabbySpecies());

		#region KrabbySpecies Constructor
		public KrabbySpecies() : base(
			98,
			"Krabby",
			Water.Instance,
			0.4,
			6.5,
			new PokemonStats(
				30, // HPs
				105, 90, // Attack & Defense
				25, 25, // Spacial Attack & Defense
				50 // Speed
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
				"Vice-Grip",
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Slam",
				"Stomp",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Strength",
				"Dig",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Harden",
				"Haze",
				"Bide",
				"Amnesia",
				"Bubble",
				"Crabhammer",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Tickle",
				"Iron-Defense",
				"Mud-Shot",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Fling",
				"X-Scissor",
				"Captivate",
				"Hone-Claws",
				"Round",
				"Chip-Away",
				"Ally-Switch",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}