using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Torchic Species to store common natural stats of all Torchics
	#region TorchicSpecies
	public class TorchicSpecies : PokemonSpecies
	{
#nullable enable
		private static TorchicSpecies? _instance = null;
#nullable restore
        public static TorchicSpecies Instance => _instance ?? (_instance = new TorchicSpecies());

		#region TorchicSpecies Constructor
		public TorchicSpecies() : base(
			255,
			"Torchic",
			Fire.Instance,
			0.4,
			2.5,
			new PokemonStats(
				45, // HPs
				60, 40, // Attack & Defense
				70, 50, // Spacial Attack & Defense
				45 // Speed
			)			
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
}