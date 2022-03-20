using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Greninja Species to store common natural stats of all Greninjas
	#region GreninjaSpecies
	public class GreninjaSpecies : PokemonSpecies
	{
#nullable enable
		private static GreninjaSpecies? _instance = null;
#nullable restore
        public static GreninjaSpecies Instance => _instance ?? (_instance = new GreninjaSpecies());

		#region GreninjaSpecies Constructor
		public GreninjaSpecies() : base(
			658,
			"Greninja",
			Water.Instance, Dark.Instance,
			1.5,
			40.0,
			new PokemonStats(
				72, // HPs
				95, 67, // Attack & Defense
				103, 71, // Spacial Attack & Defense
				122 // Speed
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
				"Pound",
				"Ice-Punch",
				"Cut",
				"Growl",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Smokescreen",
				"Haze",
				"Lick",
				"Waterfall",
				"Bubble",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Spikes",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Role-Play",
				"Snatch",
				"Secret-Power",
				"Dive",
				"Hydro-Cannon",
				"Rock-Tomb",
				"Extrasensory",
				"Aerial-Ace",
				"Bounce",
				"Water-Pulse",
				"U-Turn",
				"Fling",
				"Dark-Pulse",
				"Night-Slash",
				"Giga-Impact",
				"Shadow-Sneak",
				"Gunk-Shot",
				"Grass-Knot",
				"Smack-Down",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Acrobatics",
				"Water-Pledge",
				"Work-Up",
				"Mat-Block",
				"Confide",
				"Water-Shuriken",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}