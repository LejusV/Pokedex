using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gallade Species to store common natural stats of all Gallades
	#region GalladeSpecies
	public class GalladeSpecies : PokemonSpecies
	{
#nullable enable
		private static GalladeSpecies? _instance = null;
#nullable restore
        public static GalladeSpecies Instance => _instance ?? (_instance = new GalladeSpecies());

		#region GalladeSpecies Constructor
		public GalladeSpecies() : base(
			475,
			"Gallade",
			Psychic.Instance, Fighting.Instance,
			1.6,
			52.0,
			new PokemonStats(
				68, // HPs
				125, 65, // Attack & Defense
				65, 115, // Spacial Attack & Defense
				80 // Speed
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Leer",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Teleport",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Signal-Beam",
				"Aerial-Ace",
				"Bulk-Up",
				"Calm-Mind",
				"Leaf-Blade",
				"Shock-Wave",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Fling",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Psycho-Cut",
				"Zen-Headbutt",
				"Trick-Room",
				"Stone-Edge",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Wide-Guard",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Quick-Guard",
				"Ally-Switch",
				"Heal-Pulse",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}