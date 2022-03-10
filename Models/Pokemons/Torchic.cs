using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Torchic Species to store common natural stats of all Torchics
	#region SpeciesTorchic
	public class SpeciesTorchic : PokemonSpecies
	{
#nullable enable
		private static SpeciesTorchic? _instance = null;
#nullable restore
        public static SpeciesTorchic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTorchic();
                }
                return _instance;
            }
        }

		#region SpeciesTorchic Constructor
		public SpeciesTorchic() : base(
			"Torchic",
			0.4,
			2.5,
			45, // HPs
			60, 40, // Attack & Defense
			70, 50, // Special Attack & Defense
			45		
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
				"Mega-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Ember",
				"Flamethrower",
				"Peck",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Mirror-Move",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Smelling-Salts",
				"Helping-Hand",
				"Secret-Power",
				"Feather-Dance",
				"Crush-Claw",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bounce",
				"Natural-Gift",
				"Feint",
				"Last-Resort",
				"Night-Slash",
				"Shadow-Claw",
				"Captivate",
				"Hone-Claws",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Fire-Pledge",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Torchic PokemonInstance Class
	#region Torchic
	public class TorchicInstance : PokemonInstance
	{
		#region Torchic Constructors
		/// <summary>
		/// Torchic Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TorchicInstance(string nickname, int level)
		: base(
				255,
				SpeciesTorchic.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torchic Builder only waiting for a Level
		/// </summary>
		public TorchicInstance(int level)
		: base(
				255,
				SpeciesTorchic.Instance, // PokemonInstance Species
				"Torchic", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torchic Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Torchic() : base(
			255,
			SpeciesTorchic.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}