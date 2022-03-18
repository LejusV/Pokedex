using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hoothoot Species to store common natural stats of all Hoothoots
	#region SpeciesHoothoot
	public class SpeciesHoothoot : PokemonSpecies
	{
#nullable enable
		private static SpeciesHoothoot? _instance = null;
#nullable restore
        public static SpeciesHoothoot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHoothoot();
                }
                return _instance;
            }
        }

		#region SpeciesHoothoot Constructor
		public SpeciesHoothoot() : base(
			163,
			"Hoothoot",
			0.7,
			21.2,
			60, // HPs
			30, 30, // Attack & Defense
			36, 56, // Special Attack & Defense
			50		
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
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Supersonic",
				"Peck",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Agility",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Mirror-Move",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Feather-Dance",
				"Hyper-Voice",
				"Air-Cutter",
				"Silver-Wind",
				"Extrasensory",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Psycho-Shift",
				"Air-Slash",
				"Zen-Headbutt",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Hurricane",
				"Moonblast",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Hoothoot PokemonInstance Class
	#region Hoothoot
	public class HoothootInstance : PokemonInstance
	{
		#region Hoothoot Constructors
		/// <summary>
		/// Hoothoot Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HoothootInstance(string nickname, int level)
		: base(
				SpeciesHoothoot.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoothoot Builder only waiting for a Level
		/// </summary>
		public HoothootInstance(int level)
		: base(
				SpeciesHoothoot.Instance, // PokemonInstance Species
				"Hoothoot", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoothoot Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HoothootInstance() : base(
			SpeciesHoothoot.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}