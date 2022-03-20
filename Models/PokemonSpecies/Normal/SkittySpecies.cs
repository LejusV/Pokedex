using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Skitty Species to store common natural stats of all Skittys
	#region SkittySpecies
	public class SkittySpecies : PokemonSpecies
	{
#nullable enable
		private static SkittySpecies? _instance = null;
#nullable restore
        public static SkittySpecies Instance => _instance ?? (_instance = new SkittySpecies());

		#region SkittySpecies Constructor
		public SkittySpecies() : base(
			300,
			"Skitty",
			Normal.Instance,
			0.6,
			11.0,
			new PokemonStats(
				50, // HPs
				45, 45, // Attack & Defense
				35, 35, // Spacial Attack & Defense
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
				"Double-Slap",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Sing",
				"Ice-Beam",
				"Blizzard",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Fake-Out",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Wish",
				"Assist",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Tickle",
				"Cosmic-Power",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Payback",
				"Copycat",
				"Last-Resort",
				"Sucker-Punch",
				"Mud-Bomb",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Simple-Beam",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Disarming-Voice",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}