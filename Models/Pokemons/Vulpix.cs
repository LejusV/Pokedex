using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Vulpix Species to store common natural stats of all Vulpixs
	#region SpeciesVulpix
	public class SpeciesVulpix : PokemonSpecies
	{
#nullable enable
		private static SpeciesVulpix? _instance = null;
#nullable restore
        public static SpeciesVulpix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVulpix();
                }
                return _instance;
            }
        }

		#region SpeciesVulpix Constructor
		public SpeciesVulpix() : base(
			"Vulpix",
			0.6,
			9.9,
			38, // HPs
			41, 40, // Attack & Defense
			50, 65, // Special Attack & Defense
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
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Roar",
				"Disable",
				"Ember",
				"Flamethrower",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Hypnosis",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Role-Play",
				"Imprison",
				"Grudge",
				"Secret-Power",
				"Overheat",
				"Extrasensory",
				"Howl",
				"Covet",
				"Natural-Gift",
				"Payback",
				"Power-Swap",
				"Flare-Blitz",
				"Dark-Pulse",
				"Energy-Ball",
				"Zen-Headbutt",
				"Captivate",
				"Ominous-Wind",
				"Flame-Burst",
				"Flame-Charge",
				"Foul-Play",
				"Round",
				"Hex",
				"Incinerate",
				"Inferno",
				"Tail-Slap",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Vulpix PokemonInstance Class
	#region Vulpix
	public class VulpixInstance : PokemonInstance
	{
		#region Vulpix Constructors
		/// <summary>
		/// Vulpix Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VulpixInstance(string nickname, int level)
		: base(
				37,
				SpeciesVulpix.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vulpix Builder only waiting for a Level
		/// </summary>
		public VulpixInstance(int level)
		: base(
				37,
				SpeciesVulpix.Instance, // PokemonInstance Species
				"Vulpix", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vulpix Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Vulpix() : base(
			37,
			SpeciesVulpix.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}