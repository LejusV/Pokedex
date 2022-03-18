using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Clawitzer Species to store common natural stats of all Clawitzers
	#region SpeciesClawitzer
	public class SpeciesClawitzer : PokemonSpecies
	{
#nullable enable
		private static SpeciesClawitzer? _instance = null;
#nullable restore
        public static SpeciesClawitzer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesClawitzer();
                }
                return _instance;
            }
        }

		#region SpeciesClawitzer Constructor
		public SpeciesClawitzer() : base(
			693,
			"Clawitzer",
			1.3,
			35.3,
			71, // HPs
			73, 88, // Attack & Defense
			120, 89, // Special Attack & Defense
			59		
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
				"Vice-Grip",
				"Swords-Dance",
				"Cut",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Bubble-Beam",
				"Hyper-Beam",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Bubble",
				"Splash",
				"Crabhammer",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Shadow-Ball",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Dive",
				"Muddy-Water",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"U-Turn",
				"Aura-Sphere",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Flash-Cannon",
				"Aqua-Jet",
				"Venoshock",
				"Smack-Down",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Heal-Pulse",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Clawitzer PokemonInstance Class
	#region Clawitzer
	public class ClawitzerInstance : PokemonInstance
	{
		#region Clawitzer Constructors
		/// <summary>
		/// Clawitzer Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ClawitzerInstance(string nickname, int level)
		: base(
				SpeciesClawitzer.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clawitzer Builder only waiting for a Level
		/// </summary>
		public ClawitzerInstance(int level)
		: base(
				SpeciesClawitzer.Instance, // PokemonInstance Species
				"Clawitzer", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clawitzer Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ClawitzerInstance() : base(
			SpeciesClawitzer.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}