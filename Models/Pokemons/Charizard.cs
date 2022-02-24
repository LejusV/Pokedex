using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Charizard Specie to store common natural stats of every {'abilities': ['blaze', 'solar-power'], 'base_experience': 240, 'height': 17, 'id': 6, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'scratch', 'swords-dance', 'cut', 'wing-attack', 'fly', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'leer', 'growl', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'dragon-rage', 'fire-spin', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'smokescreen', 'defense-curl', 'reflect', 'bide', 'fire-blast', 'swift', 'skull-bash', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'curse', 'protect', 'scary-face', 'mud-slap', 'outrage', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'dragon-breath', 'iron-tail', 'metal-claw', 'hidden-power', 'twister', 'sunny-day', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'focus-punch', 'brick-break', 'secret-power', 'blast-burn', 'air-cutter', 'overheat', 'rock-tomb', 'aerial-ace', 'dragon-claw', 'roost', 'natural-gift', 'tailwind', 'fling', 'flare-blitz', 'air-slash', 'dragon-pulse', 'focus-blast', 'giga-impact', 'shadow-claw', 'fire-fang', 'defog', 'captivate', 'ominous-wind', 'hone-claws', 'flame-burst', 'flame-charge', 'round', 'echoed-voice', 'sky-drop', 'incinerate', 'inferno', 'fire-pledge', 'bulldoze', 'dragon-tail', 'work-up', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'charizard', 'stats': {'hp': 78, 'attack': 84, 'defense': 78, 'special-attack': 109, 'special-defense': 85, 'speed': 100}, 'types': ['fire', 'flying'], 'weight': 905, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'リザードン', 'roomaji': 'Lizardon', 'ko': '리자몽', 'zh-Hant': '噴火龍', 'fr': 'Dracaufeu', 'de': 'Glurak', 'es': 'Charizard', 'it': 'Charizard', 'en': 'Charizard', 'ja': 'リザードン', 'zh-Hans': '喷火龙'}, 'genera': {'ja-Hrkt': 'かえんポケモン', 'ko': '화염포켓몬', 'zh-Hant': '火焰寶可夢', 'fr': 'Pokémon Flamme', 'de': 'Flamme', 'es': 'Pokémon Llama', 'it': 'Pokémon Fiamma', 'en': 'Flame Pokémon', 'ja': 'かえんポケモン', 'zh-Hans': '火焰宝可梦'}}
	public class SpecieCharizard : PokemonSpecie
	{
#nullable enable
		private static SpecieCharizard? _instance = null;
#nullable restore
        public static SpecieCharizard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCharizard();
                }
                return _instance;
            }
        }

		public SpecieCharizard() : base(
			"Charizard",
			78, // HPs
			84, 78, // Attack & Defense
			109, 85, // Special Attack & Defense
			100			
		) {}
	}


	//Charizard Pokemon Class
	public class Charizard : Pokemon
	{

		public Charizard(string nickname, int level)
		: base(
				6,
				SpecieCharizard.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Charizard(int level)
		: base(
				6,
				SpecieCharizard.Instance, // Pokemon Specie
				"Charizard", level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Charizard() : base(
			6,
			SpecieCharizard.Instance, // Pokemon Specie
			Fire.Instance, Flying.Instance			
		) {}
	}
}