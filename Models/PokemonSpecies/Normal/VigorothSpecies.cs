using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Vigoroth Species to store common natural stats of all Vigoroths
	#region VigorothSpecies
	public class VigorothSpecies : PokemonSpecies
	{
#nullable enable
		private static VigorothSpecies? _instance = null;
#nullable restore
        public static VigorothSpecies Instance => _instance ?? (_instance = new VigorothSpecies());

		#region VigorothSpecies Constructor
		public VigorothSpecies() : base(
			288,
			"Vigoroth",
			Normal.Instance,
			1.4,
			46.5,
			new PokemonStats(
				80, // HPs
				80, 80, // Attack & Defense
				55, 55, // Spacial Attack & Defense
				90 // Speed
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Roar",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Fire-Blast",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Sucker-Punch",
				"Focus-Blast",
				"Shadow-Claw",
				"Rock-Climb",
				"Gunk-Shot",
				"Captivate",
				"Hone-Claws",
				"Low-Sweep",
				"After-You",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}