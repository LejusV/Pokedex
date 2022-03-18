using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Basculin-Red-Striped Species to store common natural stats of all Basculin-Red-Stripeds
	#region SpeciesBasculin-Red-Striped
	public class SpeciesBasculinRedStriped : PokemonSpecies
	{
#nullable enable
		private static SpeciesBasculinRedStriped? _instance = null;
#nullable restore
        public static SpeciesBasculinRedStriped Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBasculinRedStriped();
                }
                return _instance;
            }
        }

		#region SpeciesBasculin-Red-Striped Constructor
		public SpeciesBasculinRedStriped() : base(
			550,
			"Basculin-Red-Striped",
			1.0,
			18.0,
			70, // HPs
			92, 65, // Attack & Defense
			80, 55, // Special Attack & Defense
			98		
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
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Tail-Whip",
				"Bite",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Bubble-Beam",
				"Toxic",
				"Agility",
				"Rage",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Scary-Face",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Taunt",
				"Superpower",
				"Revenge",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Muddy-Water",
				"Bounce",
				"Mud-Shot",
				"Brine",
				"Aqua-Tail",
				"Zen-Headbutt",
				"Aqua-Jet",
				"Head-Smash",
				"Soak",
				"Round",
				"Chip-Away",
				"Scald",
				"Final-Gambit",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Basculin-Red-Striped PokemonInstance Class
	#region Basculin-Red-Striped
	public class BasculinRedStripedInstance : PokemonInstance
	{
		#region Basculin-Red-Striped Constructors
		/// <summary>
		/// Basculin-Red-Striped Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BasculinRedStripedInstance(string nickname, int level)
		: base(
				SpeciesBasculinRedStriped.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Basculin-Red-Striped Builder only waiting for a Level
		/// </summary>
		public BasculinRedStripedInstance(int level)
		: base(
				SpeciesBasculinRedStriped.Instance, // PokemonInstance Species
				"Basculin-Red-Striped", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Basculin-Red-Striped Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BasculinRedStripedInstance() : base(
			SpeciesBasculinRedStriped.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}