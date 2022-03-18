using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mantyke Species to store common natural stats of all Mantykes
	#region SpeciesMantyke
	public class SpeciesMantyke : PokemonSpecies
	{
#nullable enable
		private static SpeciesMantyke? _instance = null;
#nullable restore
        public static SpeciesMantyke Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMantyke();
                }
                return _instance;
            }
        }

		#region SpeciesMantyke Constructor
		public SpeciesMantyke() : base(
			458,
			"Mantyke",
			1.0,
			65.0,
			45, // HPs
			20, 50, // Attack & Defense
			60, 120, // Special Attack & Defense
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
				"Slam",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Supersonic",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Earthquake",
				"Toxic",
				"Agility",
				"Double-Team",
				"Confuse-Ray",
				"Haze",
				"Waterfall",
				"Swift",
				"Amnesia",
				"Bubble",
				"Splash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Mirror-Coat",
				"Whirlpool",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Air-Cutter",
				"Signal-Beam",
				"Aerial-Ace",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Tailwind",
				"Aqua-Ring",
				"Air-Slash",
				"Captivate",
				"Wide-Guard",
				"Round",
				"Scald",
				"Acrobatics",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Mantyke PokemonInstance Class
	#region Mantyke
	public class MantykeInstance : PokemonInstance
	{
		#region Mantyke Constructors
		/// <summary>
		/// Mantyke Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MantykeInstance(string nickname, int level)
		: base(
				SpeciesMantyke.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mantyke Builder only waiting for a Level
		/// </summary>
		public MantykeInstance(int level)
		: base(
				SpeciesMantyke.Instance, // PokemonInstance Species
				"Mantyke", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mantyke Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MantykeInstance() : base(
			SpeciesMantyke.Instance, // PokemonInstance Species
			Water.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}