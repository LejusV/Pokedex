using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Munchlax Species to store common natural stats of all Munchlaxs
	#region MunchlaxSpecies
	public class MunchlaxSpecies : PokemonSpecies
	{
#nullable enable
		private static MunchlaxSpecies? _instance = null;
#nullable restore
        public static MunchlaxSpecies Instance => _instance ?? (_instance = new MunchlaxSpecies());

		#region MunchlaxSpecies Constructor
		public MunchlaxSpecies() : base(
			446,
			"Munchlax",
			Normal.Instance,
			0.6,
			105.0,
			new PokemonStats(
				135, // HPs
				85, 40, // Attack & Defense
				40, 85, // Spacial Attack & Defense
				5 // Speed
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
				"Whirlwind",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Metronome",
				"Self-Destruct",
				"Lick",
				"Fire-Blast",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Stockpile",
				"Swallow",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Recycle",
				"Brick-Break",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Seed-Bomb",
				"Zen-Headbutt",
				"Rock-Climb",
				"Gunk-Shot",
				"Captivate",
				"After-You",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Belch",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}