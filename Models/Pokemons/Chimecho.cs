using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Chimecho Species to store common natural stats of all Chimechos
	#region SpeciesChimecho
	public class SpeciesChimecho : PokemonSpecies
	{
#nullable enable
		private static SpeciesChimecho? _instance = null;
#nullable restore
        public static SpeciesChimecho Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesChimecho();
                }
                return _instance;
            }
        }

		#region SpeciesChimecho Constructor
		public SpeciesChimecho() : base(
			"Chimecho",
			0.6,
			1.0,
			75, // HPs
			50, 80, // Attack & Defense
			95, 90, // Special Attack & Defense
			65		
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
				"Bind",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Disable",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Mimic",
				"Double-Team",
				"Recover",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Perish-Song",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Yawn",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Cosmic-Power",
				"Signal-Beam",
				"Extrasensory",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Healing-Wish",
				"Natural-Gift",
				"Last-Resort",
				"Energy-Ball",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Heal-Pulse",
				"Crafty-Shield",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Chimecho PokemonInstance Class
	#region Chimecho
	public class ChimechoInstance : PokemonInstance
	{
		#region Chimecho Constructors
		/// <summary>
		/// Chimecho Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ChimechoInstance(string nickname, int level)
		: base(
				358,
				SpeciesChimecho.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chimecho Builder only waiting for a Level
		/// </summary>
		public ChimechoInstance(int level)
		: base(
				358,
				SpeciesChimecho.Instance, // PokemonInstance Species
				"Chimecho", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chimecho Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Chimecho() : base(
			358,
			SpeciesChimecho.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}