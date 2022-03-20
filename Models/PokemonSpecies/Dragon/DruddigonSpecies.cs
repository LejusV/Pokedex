using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Druddigon Species to store common natural stats of all Druddigons
	#region DruddigonSpecies
	public class DruddigonSpecies : PokemonSpecies
	{
#nullable enable
		private static DruddigonSpecies? _instance = null;
#nullable restore
        public static DruddigonSpecies Instance => _instance ?? (_instance = new DruddigonSpecies());

		#region DruddigonSpecies Constructor
		public DruddigonSpecies() : base(
			621,
			"Druddigon",
			Dragon.Instance,
			1.6,
			139.0,
			new PokemonStats(
				77, // HPs
				120, 90, // Attack & Defense
				60, 90, // Spacial Attack & Defense
				48 // Speed
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
}