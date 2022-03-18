using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Skrelp Species to store common natural stats of all Skrelps
	#region SpeciesSkrelp
	public class SpeciesSkrelp : PokemonSpecies
	{
#nullable enable
		private static SpeciesSkrelp? _instance = null;
#nullable restore
        public static SpeciesSkrelp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSkrelp();
                }
                return _instance;
            }
        }

		#region SpeciesSkrelp Constructor
		public SpeciesSkrelp() : base(
			690,
			"Skrelp",
			0.5,
			7.3,
			50, // HPs
			60, 60, // Attack & Defense
			60, 60, // Special Attack & Defense
			30		
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
				"Tail-Whip",
				"Acid",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Thunderbolt",
				"Toxic",
				"Double-Team",
				"Smokescreen",
				"Haze",
				"Waterfall",
				"Bubble",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Icy-Wind",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Shadow-Ball",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Camouflage",
				"Bounce",
				"Poison-Tail",
				"Shock-Wave",
				"Water-Pulse",
				"Toxic-Spikes",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Gunk-Shot",
				"Venoshock",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Play-Rough",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion

	//Skrelp PokemonInstance Class
	#region Skrelp
	public class SkrelpInstance : PokemonInstance
	{
		#region Skrelp Constructors
		/// <summary>
		/// Skrelp Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SkrelpInstance(string nickname, int level)
		: base(
				SpeciesSkrelp.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skrelp Builder only waiting for a Level
		/// </summary>
		public SkrelpInstance(int level)
		: base(
				SpeciesSkrelp.Instance, // PokemonInstance Species
				"Skrelp", level,
				Poison.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skrelp Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SkrelpInstance() : base(
			SpeciesSkrelp.Instance, // PokemonInstance Species
			Poison.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}