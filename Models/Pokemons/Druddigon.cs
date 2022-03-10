using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Druddigon Species to store common natural stats of all Druddigons
	#region SpeciesDruddigon
	public class SpeciesDruddigon : PokemonSpecies
	{
#nullable enable
		private static SpeciesDruddigon? _instance = null;
#nullable restore
        public static SpeciesDruddigon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDruddigon();
                }
                return _instance;
            }
        }

		#region SpeciesDruddigon Constructor
		public SpeciesDruddigon() : base(
			"Druddigon",
			1.6,
			139.0,
			77, // HPs
			120, 90, // Attack & Defense
			60, 90, // Special Attack & Defense
			48		
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
				"Fire-Punch",
				"Thunder-Punch",
				"Scratch",
				"Cut",
				"Leer",
				"Bite",
				"Roar",
				"Flamethrower",
				"Surf",
				"Hyper-Beam",
				"Strength",
				"Dragon-Rage",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Glare",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Sludge-Bomb",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Superpower",
				"Revenge",
				"Snatch",
				"Secret-Power",
				"Crush-Claw",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Poison-Tail",
				"Shock-Wave",
				"Payback",
				"Fling",
				"Sucker-Punch",
				"Dark-Pulse",
				"Night-Slash",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Thunder-Fang",
				"Fire-Fang",
				"Flash-Cannon",
				"Rock-Climb",
				"Draco-Meteor",
				"Gunk-Shot",
				"Iron-Head",
				"Stealth-Rock",
				"Charge-Beam",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Dragon-Tail",
				"Snarl",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Druddigon PokemonInstance Class
	#region Druddigon
	public class DruddigonInstance : PokemonInstance
	{
		#region Druddigon Constructors
		/// <summary>
		/// Druddigon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DruddigonInstance(string nickname, int level)
		: base(
				621,
				SpeciesDruddigon.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Druddigon Builder only waiting for a Level
		/// </summary>
		public DruddigonInstance(int level)
		: base(
				621,
				SpeciesDruddigon.Instance, // PokemonInstance Species
				"Druddigon", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Druddigon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Druddigon() : base(
			621,
			SpeciesDruddigon.Instance, // PokemonInstance Species
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}