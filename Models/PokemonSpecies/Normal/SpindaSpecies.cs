using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Spinda Species to store common natural stats of all Spindas
	#region SpindaSpecies
	public class SpindaSpecies : PokemonSpecies
	{
#nullable enable
		private static SpindaSpecies? _instance = null;
#nullable restore
        public static SpindaSpecies Instance => _instance ?? (_instance = new SpindaSpecies());

		#region SpindaSpecies Constructor
		public SpindaSpecies() : base(
			327,
			"Spinda",
			Normal.Instance,
			1.1,
			5.0,
			new PokemonStats(
				60, // HPs
				60, 60, // Attack & Defense
				60, 60, // Spacial Attack & Defense
				60 // Speed
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
				"Thrash",
				"Double-Edge",
				"Disable",
				"Psybeam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Dig",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Metronome",
				"Swift",
				"Dream-Eater",
				"Dizzy-Punch",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Flail",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Baton-Pass",
				"Encore",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Wish",
				"Assist",
				"Recycle",
				"Brick-Break",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Teeter-Dance",
				"Hyper-Voice",
				"Fake-Tears",
				"Rock-Tomb",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Psycho-Shift",
				"Copycat",
				"Last-Resort",
				"Sucker-Punch",
				"Drain-Punch",
				"Psycho-Cut",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Guard-Split",
				"Round",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Power-Up-Punch",
				"Spotlight"
			};
		}
		#endregion
	}
	#endregion
}