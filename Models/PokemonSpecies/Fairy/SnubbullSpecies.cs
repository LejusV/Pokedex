using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Snubbull Species to store common natural stats of all Snubbulls
	#region SnubbullSpecies
	public class SnubbullSpecies : PokemonSpecies
	{
#nullable enable
		private static SnubbullSpecies? _instance = null;
#nullable restore
        public static SnubbullSpecies Instance => _instance ?? (_instance = new SnubbullSpecies());

		#region SnubbullSpecies Constructor
		public SnubbullSpecies() : base(
			209,
			"Snubbull",
			Fairy.Instance,
			0.6,
			7.8,
			new PokemonStats(
				60, // HPs
				80, 50, // Attack & Defense
				40, 40, // Spacial Attack & Defense
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
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Leer",
				"Bite",
				"Roar",
				"Flamethrower",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Metronome",
				"Lick",
				"Fire-Blast",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Present",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Overheat",
				"Bulk-Up",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Close-Combat",
				"Payback",
				"Fling",
				"Last-Resort",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Captivate",
				"Round",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Snarl",
				"Play-Rough",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}