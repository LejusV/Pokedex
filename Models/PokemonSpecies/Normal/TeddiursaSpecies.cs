using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Teddiursa Species to store common natural stats of all Teddiursas
	#region TeddiursaSpecies
	public class TeddiursaSpecies : PokemonSpecies
	{
#nullable enable
		private static TeddiursaSpecies? _instance = null;
#nullable restore
        public static TeddiursaSpecies Instance => _instance ?? (_instance = new TeddiursaSpecies());

		#region TeddiursaSpecies Constructor
		public TeddiursaSpecies() : base(
			216,
			"Teddiursa",
			Normal.Instance,
			0.6,
			8.8,
			new PokemonStats(
				60, // HPs
				80, 50, // Attack & Defense
				50, 50, // Spacial Attack & Defense
				40 // Speed
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
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Roar",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Metronome",
				"Lick",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
				"Belly-Drum",
				"Mud-Slap",
				"Zap-Cannon",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Sweet-Scent",
				"Metal-Claw",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Yawn",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Natural-Gift",
				"Close-Combat",
				"Payback",
				"Fling",
				"Last-Resort",
				"Night-Slash",
				"Seed-Bomb",
				"Shadow-Claw",
				"Gunk-Shot",
				"Captivate",
				"Hone-Claws",
				"Round",
				"Chip-Away",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Play-Rough",
				"Play-Nice",
				"Confide",
				"Baby-Doll-Eyes",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}