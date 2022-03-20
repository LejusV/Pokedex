using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Slakoth Species to store common natural stats of all Slakoths
	#region SlakothSpecies
	public class SlakothSpecies : PokemonSpecies
	{
#nullable enable
		private static SlakothSpecies? _instance = null;
#nullable restore
        public static SlakothSpecies Instance => _instance ?? (_instance = new SlakothSpecies());

		#region SlakothSpecies Constructor
		public SlakothSpecies() : base(
			287,
			"Slakoth",
			Normal.Instance,
			0.8,
			24.0,
			new PokemonStats(
				60, // HPs
				60, 60, // Attack & Defense
				35, 35, // Spacial Attack & Defense
				30 // Speed
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
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Fire-Blast",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Feint-Attack",
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
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Yawn",
				"Secret-Power",
				"Slack-Off",
				"Crush-Claw",
				"Rock-Tomb",
				"Tickle",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Sucker-Punch",
				"Night-Slash",
				"Shadow-Claw",
				"Gunk-Shot",
				"Captivate",
				"Hone-Claws",
				"After-You",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Play-Rough",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}