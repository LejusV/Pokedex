using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bergmite Species to store common natural stats of all Bergmites
	#region SpeciesBergmite
	public class SpeciesBergmite : PokemonSpecies
	{
#nullable enable
		private static SpeciesBergmite? _instance = null;
#nullable restore
        public static SpeciesBergmite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBergmite();
                }
                return _instance;
            }
        }

		#region SpeciesBergmite Constructor
		public SpeciesBergmite() : base(
			"Bergmite",
			1.0,
			99.5,
			55, // HPs
			69, 85, // Attack & Defense
			32, 35, // Special Attack & Defense
			28		
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
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Mist",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Strength",
				"Toxic",
				"Double-Team",
				"Recover",
				"Harden",
				"Barrier",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Sharpen",
				"Substitute",
				"Snore",
				"Curse",
				"Powder-Snow",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Secret-Power",
				"Ice-Ball",
				"Rock-Tomb",
				"Iron-Defense",
				"Water-Pulse",
				"Gyro-Ball",
				"Rock-Polish",
				"Avalanche",
				"Ice-Fang",
				"Flash-Cannon",
				"Stone-Edge",
				"After-You",
				"Round",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Bergmite PokemonInstance Class
	#region Bergmite
	public class BergmiteInstance : PokemonInstance
	{
		#region Bergmite Constructors
		/// <summary>
		/// Bergmite Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BergmiteInstance(string nickname, int level)
		: base(
				712,
				SpeciesBergmite.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bergmite Builder only waiting for a Level
		/// </summary>
		public BergmiteInstance(int level)
		: base(
				712,
				SpeciesBergmite.Instance, // PokemonInstance Species
				"Bergmite", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bergmite Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Bergmite() : base(
			712,
			SpeciesBergmite.Instance, // PokemonInstance Species
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}