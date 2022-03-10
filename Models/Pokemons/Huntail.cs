using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Huntail Species to store common natural stats of all Huntails
	#region SpeciesHuntail
	public class SpeciesHuntail : PokemonSpecies
	{
#nullable enable
		private static SpeciesHuntail? _instance = null;
#nullable restore
        public static SpeciesHuntail Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHuntail();
                }
                return _instance;
            }
        }

		#region SpeciesHuntail Constructor
		public SpeciesHuntail() : base(
			"Huntail",
			1.7,
			27.0,
			55, // HPs
			104, 105, // Attack & Defense
			94, 75, // Special Attack & Defense
			52		
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
				"Bind",
				"Body-Slam",
				"Double-Edge",
				"Bite",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Whirlpool",
				"Hail",
				"Facade",
				"Snatch",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Bounce",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Sucker-Punch",
				"Aqua-Tail",
				"Giga-Impact",
				"Ice-Fang",
				"Captivate",
				"Coil",
				"Round",
				"Scald",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Huntail PokemonInstance Class
	#region Huntail
	public class HuntailInstance : PokemonInstance
	{
		#region Huntail Constructors
		/// <summary>
		/// Huntail Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HuntailInstance(string nickname, int level)
		: base(
				367,
				SpeciesHuntail.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Huntail Builder only waiting for a Level
		/// </summary>
		public HuntailInstance(int level)
		: base(
				367,
				SpeciesHuntail.Instance, // PokemonInstance Species
				"Huntail", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Huntail Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Huntail() : base(
			367,
			SpeciesHuntail.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}