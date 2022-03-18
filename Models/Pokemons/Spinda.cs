using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Spinda Species to store common natural stats of all Spindas
	#region SpeciesSpinda
	public class SpeciesSpinda : PokemonSpecies
	{
#nullable enable
		private static SpeciesSpinda? _instance = null;
#nullable restore
        public static SpeciesSpinda Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSpinda();
                }
                return _instance;
            }
        }

		#region SpeciesSpinda Constructor
		public SpeciesSpinda() : base(
			327,
			"Spinda",
			1.1,
			5.0,
			60, // HPs
			60, 60, // Attack & Defense
			60, 60, // Special Attack & Defense
			60		
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

	//Spinda PokemonInstance Class
	#region Spinda
	public class SpindaInstance : PokemonInstance
	{
		#region Spinda Constructors
		/// <summary>
		/// Spinda Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SpindaInstance(string nickname, int level)
		: base(
				SpeciesSpinda.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spinda Builder only waiting for a Level
		/// </summary>
		public SpindaInstance(int level)
		: base(
				SpeciesSpinda.Instance, // PokemonInstance Species
				"Spinda", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spinda Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SpindaInstance() : base(
			SpeciesSpinda.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}