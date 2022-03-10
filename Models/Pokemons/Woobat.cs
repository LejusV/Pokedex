using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Woobat Species to store common natural stats of all Woobats
	#region SpeciesWoobat
	public class SpeciesWoobat : PokemonSpecies
	{
#nullable enable
		private static SpeciesWoobat? _instance = null;
#nullable restore
        public static SpeciesWoobat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWoobat();
                }
                return _instance;
            }
        }

		#region SpeciesWoobat Constructor
		public SpeciesWoobat() : base(
			"Woobat",
			0.4,
			2.1,
			65, // HPs
			45, 43, // Attack & Defense
			55, 43, // Special Attack & Defense
			72		
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
				"Gust",
				"Fly",
				"Supersonic",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Charm",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Flatter",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Knock-Off",
				"Endeavor",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Fake-Tears",
				"Air-Cutter",
				"Odor-Sleuth",
				"Signal-Beam",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Roost",
				"Gyro-Ball",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Assurance",
				"Embargo",
				"Psycho-Shift",
				"Air-Slash",
				"Energy-Ball",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Synchronoise",
				"After-You",
				"Round",
				"Stored-Power",
				"Acrobatics",
				"Heart-Stamp",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion

	//Woobat PokemonInstance Class
	#region Woobat
	public class WoobatInstance : PokemonInstance
	{
		#region Woobat Constructors
		/// <summary>
		/// Woobat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WoobatInstance(string nickname, int level)
		: base(
				527,
				SpeciesWoobat.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Woobat Builder only waiting for a Level
		/// </summary>
		public WoobatInstance(int level)
		: base(
				527,
				SpeciesWoobat.Instance, // PokemonInstance Species
				"Woobat", level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Woobat Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Woobat() : base(
			527,
			SpeciesWoobat.Instance, // PokemonInstance Species
			Psychic.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}