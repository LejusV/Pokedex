using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kingdra Species to store common natural stats of all Kingdras
	#region SpeciesKingdra
	public class SpeciesKingdra : PokemonSpecies
	{
#nullable enable
		private static SpeciesKingdra? _instance = null;
#nullable restore
        public static SpeciesKingdra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKingdra();
                }
                return _instance;
            }
        }

		#region SpeciesKingdra Constructor
		public SpeciesKingdra() : base(
			"Kingdra",
			1.8,
			152.0,
			75, // HPs
			95, 95, // Attack & Defense
			95, 95, // Special Attack & Defense
			85		
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
				"Double-Edge",
				"Leer",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Toxic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Focus-Energy",
				"Waterfall",
				"Swift",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Icy-Wind",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Bounce",
				"Dragon-Dance",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Dragon-Pulse",
				"Giga-Impact",
				"Flash-Cannon",
				"Draco-Meteor",
				"Iron-Head",
				"Captivate",
				"Round",
				"Scald",
				"Quash",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Kingdra PokemonInstance Class
	#region Kingdra
	public class KingdraInstance : PokemonInstance
	{
		#region Kingdra Constructors
		/// <summary>
		/// Kingdra Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KingdraInstance(string nickname, int level)
		: base(
				230,
				SpeciesKingdra.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kingdra Builder only waiting for a Level
		/// </summary>
		public KingdraInstance(int level)
		: base(
				230,
				SpeciesKingdra.Instance, // PokemonInstance Species
				"Kingdra", level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kingdra Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Kingdra() : base(
			230,
			SpeciesKingdra.Instance, // PokemonInstance Species
			Water.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}