using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gastrodon Species to store common natural stats of all Gastrodons
	#region SpeciesGastrodon
	public class SpeciesGastrodon : PokemonSpecies
	{
#nullable enable
		private static SpeciesGastrodon? _instance = null;
#nullable restore
        public static SpeciesGastrodon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGastrodon();
                }
                return _instance;
            }
        }

		#region SpeciesGastrodon Constructor
		public SpeciesGastrodon() : base(
			423,
			"Gastrodon",
			0.9,
			29.9,
			111, // HPs
			83, 68, // Attack & Defense
			92, 82, // Special Attack & Defense
			39		
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
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"String-Shot",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Recover",
				"Harden",
				"Waterfall",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Muddy-Water",
				"Block",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Earth-Power",
				"Giga-Impact",
				"Mud-Bomb",
				"Stone-Edge",
				"Captivate",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Gastrodon PokemonInstance Class
	#region Gastrodon
	public class GastrodonInstance : PokemonInstance
	{
		#region Gastrodon Constructors
		/// <summary>
		/// Gastrodon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GastrodonInstance(string nickname, int level)
		: base(
				SpeciesGastrodon.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gastrodon Builder only waiting for a Level
		/// </summary>
		public GastrodonInstance(int level)
		: base(
				SpeciesGastrodon.Instance, // PokemonInstance Species
				"Gastrodon", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gastrodon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GastrodonInstance() : base(
			SpeciesGastrodon.Instance, // PokemonInstance Species
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}