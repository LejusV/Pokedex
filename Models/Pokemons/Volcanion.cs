using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Volcanion Species to store common natural stats of all Volcanions
	#region SpeciesVolcanion
	public class SpeciesVolcanion : PokemonSpecies
	{
#nullable enable
		private static SpeciesVolcanion? _instance = null;
#nullable restore
        public static SpeciesVolcanion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVolcanion();
                }
                return _instance;
            }
        }

		#region SpeciesVolcanion Constructor
		public SpeciesVolcanion() : base(
			721,
			"Volcanion",
			1.7,
			195.0,
			80, // HPs
			110, 120, // Attack & Defense
			130, 90, // Special Attack & Defense
			70		
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
				"Cut",
				"Stomp",
				"Body-Slam",
				"Take-Down",
				"Roar",
				"Flamethrower",
				"Mist",
				"Hydro-Pump",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Haze",
				"Fire-Blast",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Sandstorm",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Weather-Ball",
				"Overheat",
				"Water-Pulse",
				"Gyro-Ball",
				"Fling",
				"Flare-Blitz",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Flash-Cannon",
				"Stone-Edge",
				"Smack-Down",
				"Sludge-Wave",
				"Flame-Charge",
				"Round",
				"Scald",
				"Incinerate",
				"Bulldoze",
				"Confide",
				"Steam-Eruption"
			};
		}
		#endregion
	}
	#endregion

	//Volcanion PokemonInstance Class
	#region Volcanion
	public class VolcanionInstance : PokemonInstance
	{
		#region Volcanion Constructors
		/// <summary>
		/// Volcanion Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VolcanionInstance(string nickname, int level)
		: base(
				SpeciesVolcanion.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volcanion Builder only waiting for a Level
		/// </summary>
		public VolcanionInstance(int level)
		: base(
				SpeciesVolcanion.Instance, // PokemonInstance Species
				"Volcanion", level,
				Fire.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volcanion Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public VolcanionInstance() : base(
			SpeciesVolcanion.Instance, // PokemonInstance Species
			Fire.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}